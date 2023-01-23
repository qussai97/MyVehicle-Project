import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-total-month-salaries',
  templateUrl: './total-month-salaries.component.html',
  styleUrls: ['./total-month-salaries.component.css']
})
export class TotalMonthSalariesComponent implements OnInit {

  formGroup =new FormGroup({
    StartDate: new FormControl(''),
    
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
    this.start=this.formGroup.value.StartDate
    const data={StartDate:this.start.toString()}
    console.log(data)
    this.homeService.TotalMonthSalaries(data);
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
