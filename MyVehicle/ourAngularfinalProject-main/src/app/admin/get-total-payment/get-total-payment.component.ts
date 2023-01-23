import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-get-total-payment',
  templateUrl: './get-total-payment.component.html',
  styleUrls: ['./get-total-payment.component.css']
})
export class GetTotalPaymentComponent implements OnInit {

  formGroup =new FormGroup({
    PaymantDate: new FormControl(''),
    
  })
  Name:string="undefined";
  currentYear:Date|any = undefined;
  constructor(private router:Router,public homeService : HomeService)  {
    this.currentYear = new Date().getFullYear();
    this.Name="MyVehicle Team"
  
  }
  ngOnInit(): void {
  }
  start:Date|any = undefined;
  GetData(){
    debugger
    this.start=this.formGroup.value.PaymantDate
    const data={PaymantDate:this.start.toString()}
    console.log(data)
    this.homeService.GetTotalPaymentInDay(data);
  }

  logout()
  {
    localStorage.clear();
    this.router.navigate(['security/login']);
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
