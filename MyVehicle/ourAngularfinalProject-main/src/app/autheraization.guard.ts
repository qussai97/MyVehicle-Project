import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { AuthService } from './Service/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AutheraizationGuard implements CanActivate {
  constructor(private toastr:ToastrService,private router:Router,public auth:AuthService){}
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const token=localStorage.getItem('token');
      //If there token It means the user will go to the page using the login not the route 
    if(token){ 
       //if there are user , then I will checked to the route of the page that the user  want to go using indexOf meathod 
    // indexOf --> search of the index of the accountant 
    
        if(state.url.indexOf('accountant')>=0){
            // if the path (routing of the page that the user try to go )
      //I will get the user from the local storge 
         let user:any=localStorage.getItem('user');
                   // check if there are a user 
          if(user){
         //to conver the user to object then you can find the role name     
            user=JSON.parse(user);
        //extract the role from the user and check if the role name is admin . it will retuen true , its mean the user can go to this page 

            if(user.role=='Accountant'){
              return true;
            }
       //if not the admin user it will return false and show toastr

            else {
              this.toastr.warning('this page for Accountant');
              this.router.navigate(['security/login']);
              return false;
            }
          
    // if there are not uer , it will retuen false 

          }
          
          
          else{
            this.toastr.warning('this page for Accountant');
            this.router.navigate(['security/login']);
            return false;
          }
 //if the user not logged and try to the go to the page from the routing 

        }
     
    

      
     else  if(state.url.indexOf('admin')>=0){
        // if the path (routing of the page that the user try to go )
  //I will get the user from the local storge 
     let user:any=localStorage.getItem('user');
               // check if there are a user 
      if(user){
     //to conver the user to object then you can find the role name     
        user=JSON.parse(user);
    //extract the role from the user and check if the role name is admin . it will retuen true , its mean the user can go to this page 

        if(user.role=='Admin'){
          return true;
        }
   //if not the admin user it will return false and show toastr

        else {
          this.toastr.warning('this page for Admin');
          this.router.navigate(['security/login']);
          return false;
        }
      
// if there are not uer , it will retuen false 

      }
      
      
      else{
        this.toastr.warning('this page for Admin');
        this.router.navigate(['security/login']);
        return false;
      }
//if the user not logged and try to the go to the page from the routing 

    }
    else  if(state.url.indexOf('client')>=0){
      // if the path (routing of the page that the user try to go )
//I will get the user from the local storge 
   let user:any=localStorage.getItem('user');
             // check if there are a user 
    if(user){
   //to conver the user to object then you can find the role name     
      user=JSON.parse(user);
  //extract the role from the user and check if the role name is admin . it will retuen true , its mean the user can go to this page 

      if(user.role=='User'){
        return true;
      }
 //if not the admin user it will return false and show toastr

      else {
        this.toastr.warning('this page for User');
        this.router.navigate(['security/login']);
        return false;
      }
    
// if there are not uer , it will retuen false 

    }
    
    
    else{
      this.toastr.warning('this page for User');
      this.router.navigate(['security/login']);
      return false;
    }
//if the user not logged and try to the go to the page from the routing 

  }
    return true;
    }
    
    else { 
      this.toastr.warning('You Are Not Autherized');
      this.router.navigate(['security/login']);
    return false 
  }
  
  }
  
}
