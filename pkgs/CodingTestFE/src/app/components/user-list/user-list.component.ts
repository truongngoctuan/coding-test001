import { Component, OnInit } from '@angular/core';
import { User, UserServiceApiClient } from 'src/api-client/User';
import { UserService } from 'src/services/user.service';

@Component({
  selector: 'cm-users',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss'],
  providers: [UserService, UserServiceApiClient],
})
export class UserListComponent implements OnInit {
  constructor(private userService: UserService) { }
  pageTitle: string = 'User list';
  users: User[] = [];

  ngOnInit(): void {
    this.userService.getUsers()
      .subscribe({
        next: value => this.users = value
      });
  }
}
