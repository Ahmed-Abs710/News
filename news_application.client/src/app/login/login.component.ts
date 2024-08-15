import { Component } from '@angular/core';
import { LoginService } from '../Services/login.service';
import { Logindto } from '../../Headers/Logindto';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  logdto: Logindto = {
    UserName :'',
    Password :''
  }
  result: string = '';
  constructor(public serv: LoginService,private rout : Router) { }

  Login() {
    this.serv.Login(this.logdto).subscribe(res => {
      var st = Object.values(res).toString();
      if (st.length == 28) {
        this.result = st;
      } else {
        if (this.Decode(st)['IsAdmin'] == 'True') {
          localStorage.setItem('userid', this.Decode(st)['UserId']);
          this.rout.navigateByUrl('Dashboard');
        } else {
          localStorage.setItem('userid', this.Decode(st)['UserId']);
          this.rout.navigateByUrl('/');
        }
       
      }
    });
  }
  Decode(token: string) {
    const payload = token.split('.')[1];
    return JSON.parse(atob(payload));
  }
}
