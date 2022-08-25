import Vue from 'vue'
import VueRouter from 'vue-router'

import myLogin from '@/components/myLogin.vue'
import myHome from '@/components/myHome.vue'
// 导入台账组件
import InvoicingLedger from '@/components/standingBook/InvoicingLedger.vue'
import user from '@/components/standingBook/user.vue'
import userdetail from '@/components/standingBook/userdetail.vue'
import businessledger from '@/components/standingBook/businessledger.vue'
import businessdetail from '@/components/standingBook/businessdetail.vue'
import invoicingdetail from '@/components/standingBook/invoicingdetail.vue'
// 导入设置组件
import salesparam from '@/components/settings/salesparam.vue'
//导入消息
import message from '@/components/standingBook/message.vue'
import messagedetail from '@/components/standingBook/messagedetail.vue'

Vue.use(VueRouter)

const routes = [
  { path:'/',redirect: "/login"},
  {
    path: '/login',
    component: myLogin
  },
  { path: '/home', component: myHome, redirect: '/home/user',
    children:[
      { path:'invoicing', component: InvoicingLedger },
      { path:'invoicingdetail/:sid', component:invoicingdetail, props:true },
      { path:'business', component:businessledger },
      { path:'businessdetail/:sid', component:businessdetail, props:true },
      { path:'user', component: user },
      { path:'userdetail/:uid', component: userdetail , props:true },
      { path:'message',component: message},
      { path:'messagedetail',component: messagedetail}
    ]  
  },
  { path: '/settings', component: myHome, redirect: '/settings/salesparam',
    children:[
      { path:'salesparam', component: salesparam }
    ]
  }
]

const router = new VueRouter({
  routes
})

// 全局前置守卫
// router.beforeEach((to,from,next) => {
//   // 获取存储的token
//   const token = localStorage.getItem('token')
//   if(to.path !== '/login') {
//     if(token) {
//       next()
//     } else {
//       next('/login')
//     }
//   } else {
//     next()
//   }
// })

export default router
