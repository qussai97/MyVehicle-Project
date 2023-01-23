import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutModule } from './about/about.module';
import { AboutusCardComponent } from './about/aboutus-card/aboutus-card.component';
import { AboutusComponent } from './about/aboutus/aboutus.component';
import { AccountantModule } from './accountant/accountant.module';
import { AdminModule } from './admin/admin.module';
import { AuthModule } from './auth/auth.module';
import { AutheraizationGuard } from './autheraization.guard';
import { ClientModule } from './client/client.module';
import { ContactModule } from './contact/contact.module';

import { HomePageComponent } from './home-page/home-page.component';

const routes: Routes = [
  {
    path: 'about',
    loadChildren:()=>AboutModule
  },
    {
    path: 'contactus', 
    loadChildren:()=>ContactModule
    },
    {
      path:'security',
      loadChildren:()=>AuthModule
    },
    {
      path:'',
      component:HomePageComponent
    },
    {
    path:'admin',
    loadChildren:()=>AdminModule ,
    canActivate :[AutheraizationGuard]
    },
    {
      path:'accountant',
      loadChildren:()=>AccountantModule ,
      canActivate :[AutheraizationGuard]
      },
      {
        path:'client',
        loadChildren:()=>ClientModule ,
        canActivate :[AutheraizationGuard]
        }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
