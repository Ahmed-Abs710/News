import { Component, OnInit } from '@angular/core';
import { ArticleService } from '../Services/article.service';
import { ICategory } from '../../Headers/Categorydto';
import { CategoryService } from '../Services/category.service';
import { AddArticleDto } from '../../Headers/ArticleDto';
import { Editor, NgxEditorConfig } from 'ngx-editor';
import { EditorConfig, ST_BUTTONS } from 'ngx-simple-text-editor';
@Component({
  selector: 'app-add-article',
  templateUrl: './add-article.component.html',
  styleUrl: './add-article.component.css'
})
export class AddArticleComponent implements OnInit {

  constructor(private serv: ArticleService,private cate : CategoryService) { }
  cates: ICategory[] = [];

 // userid_string: string | null = localStorage.getItem('userid');
  //userid: number = 0;
 
  article: AddArticleDto = {
    categoryId : 0,
    Content: '',
    Title: '',
    Userid: 0,
    Pic:null
  };
  editor: any;
    ngOnInit(): void {
      this.cate.GetAllCategory().subscribe((res: ICategory[]) => {
        this.cates =res;
       // alert(this.cates);
      });
      this.editor = new Editor();
    }
  selectedfile?: File;
  selectedfile2?: File;

  selectFile(event: any): void {
    this.selectedfile = event.target.files[0];
   // alert(this.selectedfile?.name);
  }
  
  selectFile2(event: any): void {
    this.selectedfile2 = event.target.files[0];
    this.UploadFile();9
  }

  //configuration: NgxEditorConfig = {
  //  // toolbar: [['bold', 'italic'], ['link', 'image'], ['orderList','unorderList']]
  //  locals: {
  //    toolbar: 'bold italic underline strikethrough'
  //  }, icons: {
  //    bold: 'B', italic: 'I', underline:'U'
  //  }
  //}

  UploadFile(): void{
    const data = new FormData();
    if (this.selectedfile2) {
      data.append('file', this.selectedfile2);
    }
    this.serv.Upload(data).subscribe(res => {
      this.article.Content += '<img src="' + Object.values(res) + '" />';
    });
  }


  config: EditorConfig = {
    placeholder: '',
    buttons: ST_BUTTONS,
  };

  api: string = 'https://localhost:7242/api/Articles/UploadFiles';
  content: string = '';

 
  AddArticle() {
    this.article.Pic = this.selectedfile!;
    var data = new FormData();
    this.article.Userid = parseInt(localStorage.getItem('userid')!);
    data.append('Title', this.article.Title);
    data.append('Content', this.article.Content);
    data.append('Userid', this.article.Userid.toString());
    data.append('categoryId', this.article.categoryId.toString());
    data.append('Pic', this.article.Pic);
    this.serv.AddArticle(data).subscribe((res) => {
      alert(res);
    });
  }

}
