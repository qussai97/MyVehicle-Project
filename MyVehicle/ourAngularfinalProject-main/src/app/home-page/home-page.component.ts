import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { HomeService } from '../Service/home.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {


  constructor(private router:Router,public homeService:HomeService ,
    public tostr:ToastrService) { }

  ngOnInit(): void {
    this.GetAllLicense();
    this.GetAllInsurance();
  }

  GetAllLicense(){ this.homeService.GetAllLicense().subscribe((res:any)=>{
    this.homeService.License=res;

   console.log(this.homeService.License)

  },err=>{
   
    console.log("err")
  });



  }
  GetAllInsurance(){ this.homeService.GetAllInsurance().subscribe((reas:any)=>{
    this.homeService.Insurance=reas;
   
   console.log("homeService.Insurance")

  },err=>{
  
    console.log("err")
  });
}

}
