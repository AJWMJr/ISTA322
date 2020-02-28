-- Name: AJ McCray
-- File: RSVPSchema.sql
-- Date: February 28, 2020

.echo on
.headers on

drop table if exists RSVP;
create table RSVP (
  id int primary key,
  name text,
  email text,
  phone text,
  attending boolean);

.exit
