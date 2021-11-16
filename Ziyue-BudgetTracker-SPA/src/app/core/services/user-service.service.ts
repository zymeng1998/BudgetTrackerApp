import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { UserDetailResponse } from 'src/app/shared/models/UserDetailResponse';
import { User } from 'src/app/shared/models/User';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private http : HttpClient) { }

  getUserDetail(id: number):Observable<UserDetailResponse> {

    return this.http.get<UserDetailResponse>(`${environment.apiBaseUrl}User/Detail/${id}`);

  }
  getAllUsers():Observable<User[]> {
    return this.http.get<User[]>(`${environment.apiBaseUrl}User`);
  }
}
