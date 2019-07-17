import { Component } from '@angular/core';
import { AutocompleteService } from '../services/autocomplete.service';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  providers: [AutocompleteService]
})
export class HomeComponent {
  searchTerm: FormControl = new FormControl();
  myBooks = <any>[];

  constructor(private service: AutocompleteService) { }

  ngOnInit() {
    this.searchTerm.valueChanges.subscribe(
      term => {
        if (term != '') {
          this.service.search(term).subscribe(
            data => {
              this.myBooks = data as any[];
              //console.log(data[0].BookName);
            })
        }
      })
  }
}
