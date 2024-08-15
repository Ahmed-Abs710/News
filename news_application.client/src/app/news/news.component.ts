import { AfterViewInit, Component, ElementRef, HostListener, OnInit, ViewChild } from '@angular/core';
import { CategoryService } from '../Services/category.service';
import { ICategory } from '../../Headers/Categorydto';
import { ArticleService } from '../Services/article.service';
import { Article } from '../../Headers/ArticleDto';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrl: './news.component.css'
})
export class NewsComponent implements OnInit {
  cate: ICategory[] = [];
  lastArts: Article[] = [];
  Arts: Article[] = [];
  page = 1;
  IsLoading = false;
  key: string = '';
  @ViewChild('loadmoreTrigger') loadmoreTrigger: ElementRef | any;
  constructor(private serv: CategoryService, private servart: ArticleService) { }
    //ngAfterViewInit(): void {
    //  const observer = new IntersectionObserver(ent => {
    //    if (ent[0].isIntersecting) {
    //      this.LoadCards();
    //    }
    //  });
    //  observer.observe(this.loadmoreTrigger.nativeElement);
    //}
    ngOnInit(): void {
      this.serv.GetAllCategory().subscribe((res:ICategory[])=> {
        this.cate = res;
      })
      this.servart.GetLastArticles().subscribe((res: Article[]) => {
        this.lastArts = res;
      });
    //  this.LoadCards();
      this.servart.GetAllArticles().subscribe((res: Article[]) => {
        this.Arts = res;
      });
  }
  //@HostListener('window:scroll', ['$event'])
  //onScroll(event: any) {
    
  //  const pos = (document.documentElement.scrollTop || document.body.scrollTop)+window.innerHeight;
  //  const max = document.documentElement.scrollHeight;
  //  if (!this.IsLoading && pos >= max - 200) {
  //    this.LoadCards();
  //  }
  //}

  //LoadCards(): void {
  //  if (this.IsLoading) return;

  //  this.IsLoading = true;
  //  this.servart.GetArticles(this.page).subscribe((res: Article[]) => { 
  //    if (res !=null) {
  //      // this.Arts.push(...res);
  //      this.Arts = [...this.Arts, ...res];
  //      this.page++;
  //      alert(this.page);
  //    }
  //  });
  //  this.IsLoading = false;
  //}

  GetArtByCat(id : number) {
    this.servart.GetArticlesbyCat(id).subscribe((res: Article[]) => {
      this.Arts = res;
    });
  }

  Search() {
    this.servart.SearchArticle(this.key).subscribe((res: Article[]) => {
      this.Arts = res;
    });
  }
  
}
