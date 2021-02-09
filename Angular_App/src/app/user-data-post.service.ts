import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CoreApiCallComponent } from './core-api-call/core-api-call.component';
import { HttpService } from './services/http.service';
import { User } from './user.model';

@Injectable({
  providedIn: 'root'
})
export class UserDataPostService {
  public userData: User[];

  constructor(private http: HttpClient,
    private httpService: HttpService) { }


  createAndStoreUserPost(userID: string, FirstName: string, LastName: string) {

    const postUserData: User = { userId: userID, firstName: FirstName, lastName: LastName };
    this.http.
      post<{ name: string }>('https://localhost:44396/api/Author/saveUserDetails',
        postUserData).subscribe(responseData => {
          console.log(responseData);
        });
        // this.reloadUserData;
        window.location.reload();

  }

  // public reloadUserData = () => {
  //   let route: string = 'https://localhost:44396/api/Users/GetUsers';
  //   this.httpService.getData(route)
  //     .subscribe((result) => {
  //       this.userData = result as User[];
  //     },
  //       (error) => {
  //         console.error(error);
  //       });
  //       window.location.reload();
  // }
}
