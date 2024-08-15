import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddCommentDto, IComment } from '../../Headers/CommentDto';

@Injectable({
  providedIn: 'root'
})
export class CommentService {

  constructor(private api: HttpClient) { }

  getComments = 'https://localhost:7242/api/Comments/GetAllCommentByArticleId?articleId=';

  addComment = 'https://localhost:7242/api/Comments/AddComment';

  GetAllCommentsForArticle(id: string): Observable<IComment[]> {
    return this.api.get<IComment[]>(this.getComments + id);
  }

  AddCommentsForArticle(dto: AddCommentDto): Observable<IComment> {
    return this.api.post<IComment>(this.addComment,dto);
  }


}
