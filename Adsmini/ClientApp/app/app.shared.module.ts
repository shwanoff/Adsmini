import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { DescriptionComponent } from './components/shared/description/description.component';
import { TypeComponent } from './components/shared/type/type.component';
import { SearchComponent } from './components/shared/search/search.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { CardSummaryComponent } from './components/card/card-summary/card-summary.component';
import { CardDetailComponent } from './components/card/card-detail/card-detail.component';
import { CardAddComponent } from './components/card/card-add/card-add.component';
import { CardService } from './components/shared/card.service';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        HeaderComponent,
        DescriptionComponent,
        TypeComponent,
        SearchComponent,
        FooterComponent,
        CardSummaryComponent,
        CardDetailComponent,
        CardAddComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent },
            { path: 'add', component: CardAddComponent },
            { path: 'card/:id', component: CardDetailComponent },
            { path: '**', redirectTo: '' }
        ])
    ],
    providers: [CardService]
})
export class AppModuleShared {
}
