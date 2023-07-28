import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User, UserServiceApiClient } from 'src/api-client/User';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private userServiceApiClient: UserServiceApiClient) { }

  getUsers(): Observable<User[]> {
    return this.userServiceApiClient.getUsers();
  }
}
