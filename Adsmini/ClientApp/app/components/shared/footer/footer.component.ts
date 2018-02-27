import { Component } from '@angular/core';

@Component({
    selector: 'footer-component',
    templateUrl: './footer.component.html'
})
export class FooterComponent {
    title = "footer";
    author = "Шванов Вадим";
    year = 2018;
    link = "https://shwanoff.ru/about/";
    content = "Все права защищены.";
}