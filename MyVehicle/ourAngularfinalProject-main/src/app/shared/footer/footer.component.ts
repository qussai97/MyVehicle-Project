import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  webemail:string="undefined";
  webPhone1:string="undefined";
  webPhone2:string="undefined"
    webAddress:string="undefined";



  Name:string="undefined";
  email:string="undefined";
  Phone:string="undefined";
 
  currentYear:Date|any = undefined;
  constructor(private router:Router)  {
    this.currentYear = new Date().getFullYear();
    this.webemail="MyVehicle@Company.com"
    this.webPhone1="+962-798562481"
    this.webPhone2="+962-797525063"
    this.webAddress="PQCR+WHF,Amman"
   this.Name="My Vheicle Team"
    
   }
  ngOnInit(): void {
  }

  
  GoToAbout()
  {
    this.router.navigate(['about'])
  }

  GoToContact()
  {
    this.router.navigate(['contactus'])
  }
  GoToHome()
  {

    this.router.navigate([''])
  }
 


}
