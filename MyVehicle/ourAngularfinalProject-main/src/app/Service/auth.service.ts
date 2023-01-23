import {  HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { HomeService } from './home.service';
import jwtDecode from 'jwt-decode';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  data:any=[{}]
  constructor(private spinner: NgxSpinnerService,private router:Router,public homeService:HomeService,private http:HttpClient,private toastr:ToastrService) { }
  formGroup =new FormGroup({
    
    username :new FormControl('', [Validators.required]),
    password : new FormControl('', [Validators.required,Validators.minLength(10)]),
    
  
})
  
  usernameControl = new FormControl('', [Validators.required]);
  passwordControl = new FormControl('', [Validators.required,Validators.minLength(10)]);
  
  
  submit(){
    var responce1:any;
    var body={
      Username:this.formGroup.value.username.toString(),
      Password:this.formGroup.value.password.toString()
    };
    const headerDict={
      'Content-Type':'application/json',
      'Accept':'application/json'
    }
    const requestOptions={
      headers:new HttpHeaders(headerDict)
    }
    
       this.spinner.show();
     
      this.http.post('https://localhost:44373/api/Jwt',body,requestOptions).subscribe((res:any)=>{
        
       this.spinner.hide()
        responce1=res;
        const responce={
          token:responce1.toString()};
          localStorage.setItem('token',responce.token);
          let data:any=jwtDecode(responce.token);//username: rolename

          //var str=JSON.stringify({...data});
       localStorage.setItem('user',JSON.stringify({...data}));

         if(data.role=='Admin'){
           this.router.navigate(['admin/admin']);
         }
         else if(data.role=='User'){
           this.router.navigate(['client/client']);
         }
         else if(data.role=='Accountant')
         {
           this.router.navigate(['accountant/accountant']);
         }
        }
        )
          this.spinner.hide();
    }
    

    register(data:any)
    {
     this.spinner.show();
     this.http.post('https://localhost:44373/api/UserRegistration',data).subscribe(
       (result:any)=>{
         this.toastr.success('New Customer Created');
        this.spinner.hide();
      },
        err=>{
        this.spinner.hide();
        this.toastr.error('Not Created');
     
    })

  }

  
}