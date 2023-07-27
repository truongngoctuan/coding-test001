import { Injectable } from '@angular/core';
import { User } from 'src/api-client/User';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  getUsers(): User[] {
    return [
      {
        UserId: 'a1',
        FirstName: 'first name 1',
        LastName: 'last name 1',
      },
      {
        UserId: 'a2',
        FirstName: 'first name 2',
        LastName: 'last name 2',
      },
      {
        UserId: 'a3',
        FirstName: 'first name 3',
        LastName: 'last name 3',
      },
    ];
  }
}
