import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, tap } from 'rxjs';
export type User = {
  UserId: string;
  FirstName: string;
  LastName: string;
};

@Injectable({
  providedIn: 'root',
})
export class UserServiceApiClient {
  constructor(private http: HttpClient) { }
  private userUrl = 'data/json/users.json';
  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.userUrl);

    // .pipe(tap(data => console.log('getUsers response', data)),
    //   catchError<User[], User[]>(this.handleError));
  }

  // suppose to handle error here
  // handleError(err: HttpErrorResponse) {

  // }
}
