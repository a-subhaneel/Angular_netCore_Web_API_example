import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgxSpinnerServiceService } from '../ngx-spinner-service.service';
import { HttpService } from '../services/http.service';
import { UserDataPostService } from '../user-data-post.service';
import { User } from '../user.model';

@Component({
  selector: 'app-core-api-call',
  templateUrl: './core-api-call.component.html',
  styleUrls: ['./core-api-call.component.css'],
})
export class CoreApiCallComponent implements OnInit {

  public userData: User[];


  constructor(private http: HttpClient,
    private httpService: HttpService, private userPostDataService: UserDataPostService,
    private loadingSpinner: NgxSpinnerServiceService) { }

  ngOnInit() {
    this.loadingSpinner.ngOnInit();
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

  onApiPost(userData: User) {
    userData.firstName = userData.fullName.split(' ').slice(0, -1).join(' ');
    userData.lastName = userData.fullName.split(' ').slice(-1).join(' ');
    console.log(userData);
    this.userPostDataService.createAndStoreUserPost(userData.userId, userData.firstName, userData.lastName)
  }
}
