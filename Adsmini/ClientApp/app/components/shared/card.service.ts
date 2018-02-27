import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import 'rxjs/Rx';
import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { Card } from '../../components/shared/card.type';

@Injectable()
export class CardService {
    constructor(private http: Http) { }

    getAllCards() {
        return this.http.get("api/card/getall/")
            .map(response => response.json() as Card[])
            .toPromise();
    }

    getCard(id: number) {
        return this.http.get(`api/card/get/${id}`)
            .map(response => response.json() as Card)
            .toPromise();
    }

    addCard(card: Card) {
        let headers = new Headers({
            'Content-Type':
            'application/json; charset=utf-8'
        });
        let options = new RequestOptions({ headers: headers });
        delete card["id"];
        delete card["date"];
        let body = JSON.stringify(card);
        return this.http.post('/api/card/add/', body, options)
            .map(response => response.json() as Card)
            .toPromise();
    }


}
