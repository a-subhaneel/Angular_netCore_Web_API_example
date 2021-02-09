import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Post } from './post.model';
import { PostsService } from './posts.service';
import { HttpService } from './services/http.service';
import { User } from './user.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  loadedPosts: Post[] = [];
  isFetching = false;
  public userData: User[];


  constructor(private http: HttpClient, private postsService: PostsService,
    private httpService: HttpService) { }

  ngOnInit() {
    this.fetchPosts();
    this.getUserData();
  }



  public getUserData = () => {
    let route: string = 'https://localhost:44396/api/Users/GetUsers';
    this.httpService.getData(route)
    .subscribe((result) => {
      this.userData = result as User[];
    },
    (error) => {
      console.error(error);
    });
  }
 



  onCreatePost(postData: Post) {
    // Send Http request
    console.log(postData);
    this.postsService.createAndStorePost(postData.title, postData.content)
  }

  onFetchPosts() {
    // Send Http request
    this.fetchPosts();
  }

  onClearPosts() {
    // Send Http request
  }

  private fetchPosts() {
    this.isFetching = true;
    this.http
      .get<{ [key: string]: Post }>('https://ng-http-01-3119a-default-rtdb.firebaseio.com/posts.json')
      .pipe(
        map((responseData) => {
          const postsArray: Post[] = [];
          for (const key in responseData) {
            if (responseData.hasOwnProperty(key)) {
              postsArray.push({ ...responseData[key], id: key });
            }
          }
          return postsArray;
        }))
      .subscribe(posts => {
        // console.log(posts);
        this.isFetching = false;
        this.loadedPosts = posts;

      })
  }

  sendData(){
    this.onFetchPosts();
  }
}
