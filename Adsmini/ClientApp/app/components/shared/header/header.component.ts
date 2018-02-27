import { Component } from '@angular/core';

@Component({
    selector: 'header-component',
    templateUrl: './header.component.html'
})
export class HeaderComponent {
    title = "header";
    logoPath = "./dist/logo.png";
}