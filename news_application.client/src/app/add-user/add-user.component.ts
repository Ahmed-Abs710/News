import { Component } from '@angular/core';
import { CreateUserDto } from '../../Headers/UserIF';
import { UsersService } from '../Services/users.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrl: './add-user.component.css'
})
export class AddUserComponent {

  constructor(private serv : UsersService) { }

  dto: CreateUserDto = {
    Email: '',
    IsAdmin: true,
    Password: '',
    UserName:''
  }
  show: boolean = false;
  AddUser() {
    this.serv.AddUser(this.dto).subscribe(res => {
      if (res !==null) {
        this.show = true;
      }
    });
  }

}
