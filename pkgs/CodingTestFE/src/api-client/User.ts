import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, tap } from 'rxjs';
export type User = {
  userId: string;
  firstName: string;
  lastName: string;
};

export type UserCreation = {
  firstName: string;
  lastName: string;
};

@Injectable({
  providedIn: 'root',
})
export class UserServiceApiClient {
  constructor(private http: HttpClient) { }
  // private userUrl = 'data/json/users.json';
  private userUrl = 'https://localhost:55165/User';
  getUsers(): Observable<User[]> {
    return this.http
      .get<User[]>(this.userUrl)
      .pipe(catchError(this.handleError));
  }

  addUser(user: UserCreation) {
    return this.http
      .post<User>(this.userUrl, user)
      .pipe(catchError(this.handleError));
  }

  handleError(error: HttpErrorResponse) {
    console.error(error);
    return [];
  }
}
