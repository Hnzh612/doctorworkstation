<template>
  <div v-if="this.$type == '管理员'">
    <el-card class="box-card" style="width: 80%">
      <div>
        <div style="display: flex; justify-content: center">
          <el-avatar :size="80" :src="circleUrl"></el-avatar>
        </div>
        <div>
          <el-descriptions
            title="基本信息"
            direction="vertical"
            :column="3"
            border
          >
            <el-descriptions-item label="用户名">好医生</el-descriptions-item>
            <el-descriptions-item label="用户ID"
              >18100000000</el-descriptions-item
            >
            <el-descriptions-item label="联系地址" :span="2"
              >江苏省苏州市吴中区吴中大道 1188 号</el-descriptions-item
            >
            <el-descriptions-item label="性别">
              <el-tag size="small">女</el-tag>
            </el-descriptions-item>
            <el-descriptions-item label="个人简介"
              >以高尚的医德为病人的健康保驾护航</el-descriptions-item
            >
          </el-descriptions>

          <el-descriptions
            class="margin-top"
            title="工作信息"
            :column="4"
            direction="vertical"
          >
            <el-descriptions-item label="所属医院"
              >健康中心医院</el-descriptions-item
            >
            <el-descriptions-item label="手机号"
              >1503705998</el-descriptions-item
            >
            <el-descriptions-item label="医龄">15年</el-descriptions-item>
            <el-descriptions-item label="医院地址"
              >江苏省苏州市吴中区吴中大道 1188 号</el-descriptions-item
            >
          </el-descriptions>
        </div>

        <div
          style="display: flex; justify-content: space-around; margin-top: 10px"
        >
          <el-button type="primary">修改信息</el-button>
          <!-- <el-button type="primary">修改密码</el-button> -->
        </div>
      </div>
    </el-card>
  </div>
  <notype v-else></notype>
</template>

<script>
import notype from '../utlis/notype.vue';

export default {
  components: { notype },
  data() {
    return {
      circleUrl:
        "https://cube.elemecdn.com/0/88/03b0d39583f48206768a7534e55bcpng.png",
    };
  },
};
</script>

<style scoped></style>
