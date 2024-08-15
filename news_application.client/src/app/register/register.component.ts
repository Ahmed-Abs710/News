import { Component } from '@angular/core';
import { UsersService } from '../Services/users.service';
import { CreateUserDto } from '../../Headers/UserIF';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  constructor(private serv: UsersService) { }

  dto: CreateUserDto = {
    Email: '',
    IsAdmin: false,
    Password: '',
    UserName: ''
  }
  show: boolean = false;
  AddUser() {
    this.serv.AddUser(this.dto).subscribe(res => {
      if (res !== null) {
        this.show = true;
      }
    });
  }

}
