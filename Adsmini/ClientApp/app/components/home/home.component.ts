import { Component, OnInit } from '@angular/core';
import { Card } from '../shared/card.type';
import { CardService } from '../shared/card.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
    cards: Card[];

    constructor(private cardService: CardService) {
        
    }

    ngOnInit() {
        this.cardService.getAllCards()
            .then(cards => this.cards = cards);

        let temp = this.cards;
    }
}
