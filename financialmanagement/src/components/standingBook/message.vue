<template>
  <div class="friends" v-if="this.$type == '管理员'">
    <el-row v-for="user in users" :key="user.id">
      <el-menu v-if="user.message_no > 0">
        <el-menu-item >
          <el-col :span="1">
            <el-image
              class="pic"
              :src="require('@/assets/pic_boy.png')"
              v-if="user.sex == '男'"
            ></el-image>
            <el-image
              class="pic"
              :src="require('@/assets/pic_girl.jpg')"
              v-else-if="user.sex == '女'"
            ></el-image>
            <el-image
              class="pic"
              :src="require('@/assets/system.png')"
              v-else-if="user.sex == '系统'"
            ></el-image>
          </el-col>
          <el-col :span="3"
            ><div class="name">{{ user.name }}</div></el-col
          >
          <el-col :span="10">{{ user.messagelast }}</el-col>
          <el-col :span="8"
            ><el-badge :value="user.message_no"></el-badge
          ></el-col>
          <el-col :span="1"><el-button circle @click="read(user.id)">标记已读</el-button></el-col>
        </el-menu-item>
      </el-menu>
    </el-row>
  </div>
  <notype v-else></notype>
</template>

<style lang="less" scoped>
.el-menu-item {
  box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
}
.pic {
  width: 30px;
  height: 30px;
}

.friends {
  border: 1px;
}
.name {
  padding-left: 20px;
  padding-top: 6px;
  font-size: 14px;
}
</style>

<script>
import notype from "../utlis/notype.vue";

export default {
  components: { notype },
  name: "message",
  data() {
    return {
      users: [
        {
          name: "张三",
          sex: "男",
          message_no: 1,
          messagelast: "他预约了您",
          id: 1,
        },
        {
          name: "李四",
          sex: "女",
          message_no: 0,
          messagelast: "她预约了您",
          id: 2,
        },
        {
          name: "王五",
          sex: "男",
          message_no: 1,
          messagelast: "他预约了您",
          id: 3,
        },
        {
          name: "系统消息",
          sex: "系统",
          message_no: 1,
          messagelast:
            "尊敬的用户，我们将于6.13日6：00~6：30进行停机更新，请妥善安排时间",
          id: 4,
        },
      ],
    };
  },
  methods: {
    read(row){
        for(let i = 0;i<this.users.length;i++){
            if(this.users[i].id == row) {
                this.users[i].message_no = 0
            }
        }
    }
  }
};
</script>
