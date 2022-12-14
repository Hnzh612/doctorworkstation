import request from '@/utils/requset'

// 登录
const login = (username,password) => {
    return request.get('admin/login',{
        params: {
            username,
            password
        }
    })
}
// 注册
const register = (user) => {
    return request.post('admin/addadmin',user)
}

// 获取所有患者的所有数据
const getAllUserAllInformation = (querybody) => {
    return request.get('User/GetAllUserinforamtion',{params:{
        page:querybody.page,
        name:querybody.Name, 
        age:querybody.UAge*1,
        sex:querybody.Sex
    }})
}

// 根据id查询患者
const GetUserById = (id) => {
    return request.get('User/GetUserById?id='+id)
}

// 根据患者id获取仪器数据
const GetHealthDate = (uid) => {
    return request.get('HealthData/GetDateById?id='+uid)
}
// 删除患者的所有数据
const delUserAllInfomation = (id) => {
    return request.get('User/DelUser?id='+id)
}
export default{
    login,
    register,
    getAllUserAllInformation,
    GetUserById,
    GetHealthDate,
    delUserAllInfomation
}
