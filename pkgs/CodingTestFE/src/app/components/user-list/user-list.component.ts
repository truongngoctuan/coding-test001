import { Component, OnInit } from '@angular/core';
import { User } from 'src/api-client/User';
import { UserService } from 'src/services/user.service';

@Component({
  selector: 'cm-users',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss'],
  providers: [UserService],
})
export class UserListComponent implements OnInit {
  constructor(private userService: UserService) { }
  pageTitle: string = 'User list';
  users: User[] = [];

  ngOnInit(): void {
    this.users = this.userService.getUsers();
  }
}
