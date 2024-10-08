import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowArticleComponent } from './show-article.component';

describe('ShowArticleComponent', () => {
  let component: ShowArticleComponent;
  let fixture: ComponentFixture<ShowArticleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ShowArticleComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowArticleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
