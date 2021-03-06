import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscriber } from 'rxjs';
import { Post } from './post.model';

@Injectable({
  providedIn: 'root'
})

export class PostsService {
  constructor(private http: HttpClient) { }

  createAndStorePost(title: string, content: string) {
    const postData: Post = { title: title, content: content };   
    this.http.
      post<{ name: string }>('https://ng-http-01-3119a-default-rtdb.firebaseio.com/posts.json',
        postData).subscribe(responseData => {
          console.log(responseData);
        });
  }

  fetchPosts() {


  }

}
