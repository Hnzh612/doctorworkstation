<template>
  <div v-if="this.$type == '管理员'">
    <div class="searchmean" style="margin-bottom: 10px;">
      <span class="demonstration">患者姓名：</span>
      <el-input v-model="querybody.Name"></el-input>
      <span class="demonstration">患者年龄：</span>
      <el-input v-model="querybody.UAge"></el-input>
      <span class="demonstration">患者性别：</span>
      <el-input v-model="querybody.Sex"></el-input>
      <el-button type="primary" icon="el-icon-search" circle @click="query()" style="margin-left:10px ;">查询</el-button>
      <el-button type="warning" icon="el-icon-refresh" circle @click="refresh()" style="margin-left:10px ;">刷新
      </el-button>
    </div>
    <el-table ref="singleTable" :data="tableData" highlight-current-row @current-change="handleCurrentChange"
      style="width: 100%">
      <el-table-column type="index" width="80" label="序号" align="center">
      </el-table-column>
      <el-table-column prop="BDate" label="日期" width="150" align="center">
      </el-table-column>
      <el-table-column prop="Name" label="患者姓名" width="120" align="center">
      </el-table-column>
      <el-table-column prop="Phone" label="电话" width="130" align="center">
      </el-table-column>
      <el-table-column prop="Sex" label="性别" width="250" align="center">
      </el-table-column>
      <el-table-column prop="UAge" label="年龄" width="120" align="center">
      </el-table-column>
      <el-table-column prop="BBloodpresure" label="血压" width="130" align="center">
      </el-table-column>
      <el-table-column prop="UAddress" label="地址" width="250" align="center">
      </el-table-column>
      <el-table-column fixed="right" label="操作">
        <template slot-scope="scope">
          <el-button type="text" size="small" @click="edit(scope.row.UId)">编辑</el-button>
          <el-button @click="deleteSalesConnect(scope.row)" type="text" size="small">删除</el-button>
        </template>
      </el-table-column>
    </el-table>
    <pages :total="total" :currentpage="querybody.page" @handleSizeChangeSub="handleSizeChangeFun"
      @handleCurrentChangeSub="handleCurrentChangeFun">
    </pages>
  </div>
  <notype v-else></notype>
</template>

<script> 
import pages from '../utlis/pages.vue';
import notype from '@/components/utlis/notype.vue'
import userApi from '@/api/userApi';

export default {
  components: { 
    pages,
    notype
  },
    data() {
    return {
      total:11, // 总数
      // 查询体
      querybody: {
        page:1,
        Name: "",
        UAge: "",
        Sex: ""
      },
      tableData: [],
    }
  },
  methods: {
    // 页码点击
    handleSizeChangeFun(v) {
      console.log(v)
    },

    handleCurrentChangeFun(v) { //页面点击
      console.log(v)
      this.querybody.page = v; //当前页
      this.getAllUserAllInformation(this.querybody)
    },
    // 删除患者
    async deleteSalesConnect(row) {
      this.$confirm('此操作将永久删除该患者，是否继续？', '提示', {
        confirmButtonText: '确定',
        cancelButtonText: '取消',
        type: 'warning'
      }).then(async () => {
        const { data: res } = await userApi.delUserAllInfomation(row.UId)
        if (res == 1) {
          this.$message({
            message: '删除成功',
            type: 'success'
          })
          if(this.querybody.page != 1 &&this.total %10 == 1) {
            this.querybody.page = this.querybody.page - 1
          }
          this.getAllSalesConnect(this.querybody)
        } else {
          this.$message({
            message: '删除失败',
            type: 'success'
          })
        }
      }).catch(() => {
        this.$message({
          message: '已取消删除',
          type: 'info'
        })
      })
    },
    // 编辑
    edit(UId) {
      this.$router.push('/home/userdetail/' + UId)
    },
    // 查询
    query() {
      this.getAllUserAllInformation(this.querybody)
    },
    // 刷新
    refresh() {
      this.querybody = {
        page:1,
        Name: "",
        UAge: "",
        Sex: ""
      }
      this.getAllUserAllInformation(this.querybody)
    },
    setCurrent(row) {
      this.$refs.singleTable.setCurrentRow(row);
    },
    handleCurrentChange(val) {
      this.currentRow = val;
    },
    // 获取患者信息
    async getAllUserAllInformation(querybody) {
      const { data: res } = await userApi.getAllUserAllInformation(querybody)
      for (let i = 0; i < res.data.length; i++) {
        if(res.data[i].BDate != null) {
          this.$set(
            res.data[i], 'BDate', this.dayjs(res.data[i].BDate).format('YYYY-MM-DD')
          ) 
        } else {
          this.$set(
            res.data[i], 'BDate', this.dayjs(new Date().getTime()).format('YYYY-MM-DD')
          ) 
        }
      }
      this.tableData = res.data
      this.total = res.message*1
    }
  },
  created() {
    this.getAllUserAllInformation(this.querybody)
  }
}
</script>

<style lang="less" scoped>
.searchmean /deep/ .el-input {
  width: 100px;
  display: inline-block;
}
.inline-block {
    display: inline-block;
    margin: 0 5px 5px 0;
    height: 40px;
}
.footer {
  width: 955px;
  background-color: #F5F7FA;

  .row {
    display: inline-block;
    width: 50%;
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

.demonstration {
  margin-left: 10px;
  display: inline-block;
}
</style>