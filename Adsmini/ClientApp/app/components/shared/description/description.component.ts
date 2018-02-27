import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'description-component',
    templateUrl: './description.component.html'
})
export class DescriptionComponent {
    title = "description";
    content = "Описание приложения.";

    constructor(private router: Router) {

    }

    goToAdd() {
        this.router.navigate(["add"]);
    }
}