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
    return this.http
      .get<User[]>(this.userUrl)
      .pipe(catchError(this.handleError));
  }

  handleError(error: HttpErrorResponse) {
    console.error(error);
    return [];
  }
}
