import { Component, Input } from '@angular/core';

@Component({
    selector: 'type-component',
    templateUrl: './type.component.html'
})
export class TypeComponent {
    @Input() title: string;
    items: Array<string>;

    constructor() {
        this.items = ["Элемент 1", "Элемент 2", "Элемент 3"];
    }
}