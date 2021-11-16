import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserServiceService } from '../core/services/user-service.service';
import { UserDetailResponse } from '../shared/models/UserDetailResponse';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit {
  userId !: number;
  userDetail !: UserDetailResponse;
  constructor(private activatedRoute: ActivatedRoute, private userService: UserServiceService) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(
      p => {
        this.userId = Number(p.get('id'));
        console.log('UserId = '+ this.userId);
        this.userService.getUserDetail(this.userId).subscribe(
          m => {
            this.userDetail = m;
            console.log(this.userDetail);
          }
        );
      }
    );
  }

}
