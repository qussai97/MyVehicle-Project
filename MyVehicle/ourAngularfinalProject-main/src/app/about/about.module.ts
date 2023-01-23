import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AboutRoutingModule } from './about-routing.module';
import { AboutusCardComponent } from './aboutus-card/aboutus-card.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    AboutusComponent,
    AboutusCardComponent,
    
  ],
  imports: [
    CommonModule,
    AboutRoutingModule,SharedModule
    
    
  ]
})
export class AboutModule { }
