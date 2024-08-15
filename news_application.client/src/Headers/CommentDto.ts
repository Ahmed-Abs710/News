export interface IComment {
  id: number;
  content: string;
  createdDate: Date;
  username: string;
  articleId: number;
  user: any;
  article: any;
}

export interface AddCommentDto {
  Content: string;
  UserId: number;
  ArticleId: number;
}
