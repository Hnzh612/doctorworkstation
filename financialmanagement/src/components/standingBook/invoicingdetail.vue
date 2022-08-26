<template>
  <div v-if="this.$type == '管理员'">
    <div class="searchmean" style="margin-bottom: 10px">
      <el-button type="warning" icon="el-icon-check" circle @click="save()"
        >保存</el-button
      >
      <el-button type="info" icon="el-icon-arrow-left" circle @click="back()"
        >返回</el-button
      >
    </div>
    <div class="footer">
      <div class="line">
        <div class="row">
          <i>标题：</i>
          <el-input v-model="tableData.aTitle" class="input"></el-input>
        </div>
        <div class="row">
          <i>关键词：</i>
          <el-input v-model="tableData.aType" class="input"></el-input>
        </div>
        <div class="row">
          <i>时间：</i>
          <el-input disabled v-model="tableData.aTime" class="input"></el-input>
        </div>
      </div>
      <div class="line">
        <div class="row">
          <i>点赞：</i>
          <el-input disabled v-model="tableData.aAgree" class="input"></el-input>
        </div>
        <div class="row">
          <i>收藏：</i>
          <el-input disabled v-model="tableData.aCollect" class="input"></el-input>
        </div>
        <div class="row">
          <i>评论数：</i>
          <el-input disabled v-model="tableData.aLength" class="input"></el-input>
        </div>
      </div>

      <div class="line">
        <el-input
          type="textarea"
          autosize
          placeholder="请文章内容"
          v-model="tableData.aContent"
        >
        </el-input>
      </div>
    </div>
  </div>
  <notype v-else></notype>
</template>

<script>
import pages from "@/components/utlis/pages.vue";
import invoicingApi from "@/api/invoicingApi";
import notype from "@/components/utlis/notype.vue";

export default {
  components: { pages, notype },
  name: "invoicingdetail",
  props: ["aid"],
  data() {
    return {
      show: false,
      curid: 0,
      // 展示文章数据
      tableData: {},
    };
  },
  methods: {
    // 关闭添加弹窗
    showoff() {
      this.show = false;
    },
    back() {
      this.$router.go(-1);
    },
    // 保存订单
    save() {
      this.UpdateArticle(this.tableData);
    },
    // 获取选中行
    handleSelectionChange(val) {
      this.multipleSelection = val;
      if (val.length > 0) {
        this.curid = val[0].id;
      } else {
        this.curid = 0;
      }
    },
    // 获取文章信息
    async GetArticle(id) {
      const { data: res } = await invoicingApi.GetArticleById(id);
      this.tableData = res[0];
    },
    // 保存业务订单
    async UpdateArticle(invoicing) {
      const { data: res } = await invoicingApi.AddArticle(invoicing);
      if (res == 1) {
        this.$message({
          message: "保存成功",
          type: "success",
          customClass: "message",
          center: true,
          duration: 1500,
        });
      } else {
        this.$message({
          message: "保存失败!",
          type: "error",
          customClass: "message",
          center: true,
          duration: 1500,
        });
      }
    },
  },
  mounted() {
    this.GetArticle(this.aid);
  },
};
</script>

<style lang="less" scoped>
.demonstration {
  width: 100px;
  display: inline-block;
}

.inline-block {
  margin-bottom: 5px;
  height: 40px;
}
.footer {
  width: 100%;
  background-color: #f5f7fa;

  .row {
    display: inline-block;
    width: 33.3%;
    border: 1px solid #ebeef5;
  }

  i {
    margin-left: 5%;
    width: 30%;
  }

  .input {
    width: 50%;
  }

  .input/deep/.el-input__inner {
    background-color: #f5f7fa;
    border: 0;
  }
}
</style>
