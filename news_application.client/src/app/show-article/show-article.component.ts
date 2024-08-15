import { Component, OnInit } from '@angular/core';
import { ArticleService } from '../Services/article.service';
import { ActivatedRoute } from '@angular/router';
import { Article } from '../../Headers/ArticleDto';
import { CommentService } from '../Services/comment.service';
import { AddCommentDto, IComment } from '../../Headers/CommentDto';

@Component({
  selector: 'app-show-article',
  templateUrl: './show-article.component.html',
  styleUrl: './show-article.component.css'
})
export class ShowArticleComponent implements OnInit{
  constructor(private serv: ArticleService,private com :CommentService,private rout : ActivatedRoute) { }

  art: Article = {
    author: '',
    categoryId: 0,
    comments: null,
    content: '',
    id: 0,
    picPath: '',
    publishDate: new Date(),
    title: ''
  };

  comment: AddCommentDto = {
    ArticleId: 0,
    Content: '',
    UserId:0
  }

  comm: IComment[] = [];

  userId: string |null= localStorage.getItem('userid');

    ngOnInit(): void {
      this.rout.queryParams.subscribe(q => {
        this.serv.GetArticlebyId(q['id']).subscribe((res: Article) => {
          this.art = res;
        });
        this.com.GetAllCommentsForArticle(q['id']).subscribe((res: IComment[]) => {
          this.comm = res;
        });
      });
     // alert(this.userId);
    }

  AddComment() {
    this.rout.queryParams.subscribe(q => {
      this.comment.ArticleId = q['id'];
      this.comment.UserId = parseInt(this.userId!);
      alert(this.comment.ArticleId + " : " + this.comment.Content + ' : ' + this.comment.UserId);
      this.com.AddCommentsForArticle(this.comment).subscribe((res: IComment) => {
        this.comm.push(res);
      });
    });
  }

}
