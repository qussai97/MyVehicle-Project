import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { HomeService } from 'src/app/Service/home.service';

@Component({
  selector: 'app-aboutus',
  templateUrl: './aboutus.component.html',
  styleUrls: ['./aboutus.component.css']
})
export class AboutusComponent implements OnInit {
 
  constructor(private router:Router,public homeService:HomeService , public tostr:ToastrService) {
  }

  ngOnInit(): void {
    this.GetAllAbout();
  }
  GetAllAbout(){ this.homeService.GetAllAbout().subscribe((reas:any)=>{
    this.homeService.About=reas;
   console.log("homeService.Insurance")

  },err=>{
    console.log("err")
  });
}

}
