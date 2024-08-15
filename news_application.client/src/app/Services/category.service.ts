import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICategory } from '../../Headers/Categorydto';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private addcateApi = 'https://localhost:7242/api/Categories/AddCategory?Name=';

  private getallcate = 'https://localhost:7242/api/Categories/GetAllCategories';
  constructor(private api : HttpClient) { }


  public AddCategory(name : string): Observable<any> {
    return this.api.post<any>(this.addcateApi + name,null);
  }

  public GetAllCategory(): Observable<ICategory[]> {
    return this.api.get<ICategory[]>(this.getallcate);
  }

}
