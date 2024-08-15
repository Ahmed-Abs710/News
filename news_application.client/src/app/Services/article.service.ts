import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddArticleDto, Article } from '../../Headers/ArticleDto';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  uploadapi: string = 'https://localhost:7242/api/Articles/UploadFiles';

  addapi = 'https://localhost:7242/api/Articles/AddArticle';

  getlastapi = 'https://localhost:7242/api/Articles/GetLastArticles';

  getartcles = 'https://localhost:7242/api/Articles/GetArticles?page=3&pagesize=5';

  artbycar = 'https://localhost:7242/api/Articles/GetArticleByCategoryid?id=';

  getAll = 'https://localhost:7242/api/Articles/GetAllArticles';

  search = 'https://localhost:7242/api/Articles/SearchArticle?key=';

  getbyId = 'https://localhost:7242/api/Articles/GetArticleById?id=';

  constructor(private api: HttpClient) { }

  Upload(file: FormData): Observable<any> {
   return this.api.post<any>(this.uploadapi, file);
  }

  AddArticle(dto: FormData): Observable<any>{
    return this.api.post<any>(this.addapi,dto);
  }

  GetLastArticles(): Observable<Article[]> {
    return this.api.get<Article[]>(this.getlastapi);
  }

  GetArticles(page : number): Observable<Article[]> {
    return this.api.get<Article[]>(`https://localhost:7242/api/Articles/GetArticles?page=${page}&pagesize=5`);
  }

  GetAllArticles(): Observable<Article[]> {
    return this.api.get<Article[]>(this.getAll);
  }


  GetArticlesbyCat(page: number): Observable<Article[]> {
    return this.api.get<Article[]>(this.artbycar+page);
  }

  SearchArticle(page: string): Observable<Article[]> {
    return this.api.get<Article[]>(this.search + page);
  }

  GetArticlebyId(page: string): Observable<Article> {
    return this.api.get<Article>(this.getbyId + page);
  }


}
