import { Component } from '@angular/core';

@Component({
    selector: 'search-component',
    templateUrl: './search.component.html'
})
export class SearchComponent {
    title = "search";
    input: string;

    search(input: string) {
        this.input = input;
        console.log(this.input);
    }
}