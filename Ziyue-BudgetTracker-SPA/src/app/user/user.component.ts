import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserServiceService } from '../core/services/user-service.service';
import { User } from '../shared/models/User';
import { UserDetailResponse } from '../shared/models/UserDetailResponse';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  myPageTitle  = "Budget Tracker SPA";
  allUsers !: User[];

  constructor(private userService: UserServiceService) { }

  ngOnInit(): void {
    this.userService.getAllUsers().subscribe(
      m => {
        this.allUsers = m;
        console.table(this.allUsers);
      }
    );

  }

}
