import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ThemePalette } from '@angular/material/core';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { Router } from '@angular/router';
import { NgxSpinnerService } from "ngx-spinner";
import { AuthService } from 'src/app/Service/auth.service';
import { HomeService } from 'src/app/Service/home.service';
import { GoogleLoginProvider,SocialLoginModule, SocialAuthServiceConfig,SocialAuthService} from 'angularx-social-login';  

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  // usernameControl = new FormControl('', [Validators.required]);
  // passwordControl = new FormControl('', [Validators.required,Validators.minLength(10)]);
  isLoggedin: boolean = false;
  constructor(private spinner: NgxSpinnerService,private socialAuthService: SocialAuthService,private router:Router, public authService :AuthService) { }

  ngOnInit(): void {
  }
  submitted = false;
  // convenience getter for easy access to form fields
  
  // Initial implicite flow using OAuth2 protocol
  loginWithGoogle(): void {
    this.socialAuthService.signIn(GoogleLoginProvider.PROVIDER_ID);
  }
  Remember()
  {
    let key=this.authService.usernameControl.value;

    localStorage.setItem(key,this.authService.passwordControl.value);

    let getLocalData=localStorage.getItem(key);
    
  }

 



 }
