import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CurrencyPipe } from '@angular/common';
import { Card } from '../../shared/card.type'
import { CardService } from '../../shared/card.service';

@Component({
    selector: 'card-detail-component',
    templateUrl: './card-detail.component.html'
})
export class CardDetailComponent implements OnInit {
    card: Card;

    constructor(private route: ActivatedRoute, private cardService: CardService) {
        this.card = new Card();
    }

    ngOnInit() {
        this.route.params.subscribe(params => {
            let id = +params["id"];
            this.cardService.getCard(id)
                .then(card => {
                    this.card = card;
                    console.log(this.card);
                });
            
        });
    } 
}