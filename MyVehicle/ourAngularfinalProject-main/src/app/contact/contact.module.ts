import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactRoutingModule } from './contact-routing.module';
import { ContactCardComponent } from './contact-card/contact-card.component';
import { ContactusComponent } from './contactus/contactus.component';
import { SharedModule } from '../shared/shared.module';
import { FormGroup } from '@angular/forms';

@NgModule({
  declarations: [
    ContactCardComponent,
    ContactusComponent,
 
  ],
  imports: [
    CommonModule,
    ContactRoutingModule,
    SharedModule,  

    
  ]
})
export class ContactModule { }
