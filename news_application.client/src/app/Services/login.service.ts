import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Logindto } from '../../Headers/Logindto';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private loginApi:string= 'https://localhost:7242/api/Login/Login';
  constructor(private api: HttpClient) { }

  public Login(log : Logindto): Observable<any> {
    return this.api.post<any>(this.loginApi,log);
  }
    
}
