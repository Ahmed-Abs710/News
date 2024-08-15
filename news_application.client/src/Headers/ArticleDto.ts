export interface AddArticleDto {
  Title: string;
  Content: string;
  Userid: number;
  categoryId: number;
  Pic: File | null;
}

export interface Article{
  id: number;
  title: string;
  content: string;
  picPath: string;
  publishDate: any;
  author: string;
  categoryId: number;
  comments: any;
}
