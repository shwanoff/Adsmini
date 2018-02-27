import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Card } from '../../shared/card.type';

@Component({
    selector: 'card-summary-component',
    templateUrl: './card-summary.component.html'
})
export class CardSummaryComponent {
    @Input() card: Card;

    constructor(private router: Router) {

    }

    goToDetail() {
        this.router.navigate(["card", this.card.id]);
    }
}