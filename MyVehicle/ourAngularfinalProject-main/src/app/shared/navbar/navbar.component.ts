import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(private router:Router) { }

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
  GoToLogin()
  {
    this.router.navigate(['security/login'])
  }
  GoToHome()
  {

    this.router.navigate([''])
  }
  GoToRegister(){
    this.router.navigate(['security/register'])
  }
}
