import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User, UserCreation, UserServiceApiClient } from 'src/api-client/User';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private userServiceApiClient: UserServiceApiClient) { }

  getUsers(): Observable<User[]> {
    return this.userServiceApiClient.getUsers();
  }

  addUser(user: UserCreation) {
    return this.userServiceApiClient.addUser(user);
  }
}
