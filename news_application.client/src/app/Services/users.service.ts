import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CreateUserDto } from '../../Headers/UserIF';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private adduserApi = 'https://localhost:7242/api/User/Add';

  constructor(private api: HttpClient) { }

  public AddUser(dto: CreateUserDto): Observable<any> {
   return this.api.post<any>(this.adduserApi, dto);
  }


}
