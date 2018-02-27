import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { NgModel } from '@angular/forms';
import { Card } from '../../shared/card.type';
import { CardService } from '../../shared/card.service';

@Component({
    selector: 'card-add-component',
    templateUrl: './card-add.component.html'
})
export class CardAddComponent {
    card: Card;

    constructor(private cardService: CardService, private router: Router) {
        this.card = new Card();
    }

    add() {
        this.cardService.addCard(this.card)
            .then(card => {
                this.card = card;
                this.router.navigate(["card", card.id]);
            });
        
    }
}